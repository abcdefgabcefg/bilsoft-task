import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http'

import { DisplayProduct } from './displayProduct'

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  productUrl: string = "https://localhost:44335/api/product";
  productCreatedCallbacks: (() => any)[] = [];

  constructor(private http: HttpClient){ 

  }

  get(skip: number, take: number): Observable<DisplayProduct[]>{
    const products = this.http.get<DisplayProduct[]>(`${this.productUrl}?skip=${skip}&take=${take}`);

    return products;
  }

  count(): Observable<number>{
    const count = this.http.get<number>(`${this.productUrl}/count`);

    return count;
  }

  create(product: any): Observable<any>{
    const response = this.http.post(this.productUrl, product);

    return response;
  }
}

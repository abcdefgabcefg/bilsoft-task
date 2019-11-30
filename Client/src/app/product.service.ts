import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

import { DisplayProduct } from './displayProduct';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  productUrl: string = environment.baseUrl + environment.productUrl;

  constructor(private http: HttpClient){ 
    
  }

  get(skip: number, take: number): Observable<DisplayProduct[]>{
    const products = this.http.get<DisplayProduct[]>(`${this.productUrl}?skip=${skip}&take=${take}`);

    return products;
  }

  count(): Observable<number>{
    const count = this.http.get<number>(`${this.productUrl}/${environment.countUrl}`);

    return count;
  }

  create(product: any): Observable<any>{
    const response = this.http.post(this.productUrl, product);

    return response;
  }
}

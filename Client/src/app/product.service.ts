import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http'

import { DisplayProduct } from './displayProduct'

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  productUrl: string = "https://localhost:44335/api/product";

  constructor(private http: HttpClient){ 

  }

  getAll(): Observable<DisplayProduct[]>{
    var products = this.http.get<DisplayProduct[]>(this.productUrl);

    return products;
  }
}

import { Component, OnInit } from '@angular/core';
import { DisplayProduct } from '../displayProduct';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
@Injectable()
export class ProductListComponent implements OnInit {
  products: DisplayProduct[];

  constructor(private http: HttpClient) {
    http
      .get<DisplayProduct[]>(`https://localhost:44335/api/product`)
      .subscribe(products => this.products = products);
  }

  ngOnInit() {
  }

}

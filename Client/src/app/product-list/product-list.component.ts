import { Component, OnInit } from '@angular/core';
import { DisplayProduct } from '../displayProduct';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ProductService } from '../product.service'

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
@Injectable()
export class ProductListComponent implements OnInit {
  products: DisplayProduct[];

  constructor(
    private http: HttpClient,
    private productService: ProductService) {
  }

  ngOnInit() {
    this.getAll();
  }

  getAll(){
    this.productService.getAll().subscribe(products => {
      this.products = products;
      console.log("Product list got products");
      console.log(this.products);
    });
  }

  changePage(page: number): void{
    console.log(`page will change to ${page}`);
  }
}

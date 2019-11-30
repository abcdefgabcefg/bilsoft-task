import { Component, OnInit } from '@angular/core';
import { DisplayProduct } from '../displayProduct';
import { Injectable } from '@angular/core';

import { ProductService } from '../product.service'

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
@Injectable()
export class ProductListComponent implements OnInit {
  products: DisplayProduct[];
  take: number = 2;

  constructor(
    private productService: ProductService) {
  }

  ngOnInit() {
    this.productService.productCreatedCallbacks.push(() => this.get(0));
    this.get(0);
  }

  get(skip: number){
    this.productService.get(skip, this.take).subscribe(products => {
      this.products = products;
    });
  }

  changePage(page: number): void{
    const skip = (page - 1) * this.take;
    this.get(skip);
  }
}

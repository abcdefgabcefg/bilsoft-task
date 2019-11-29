import { Component, OnInit } from '@angular/core';
import { DisplayProduct } from '../displayProduct'

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: DisplayProduct[] = [
    {
      id: "d6bc3b28-e1e0-4123-88ad-b10158d24af0",
      title: "product 1",
      category: "category 1"
    },
    {
      id: "21deeeaa-3e59-497b-bbfb-0401fd362ce5",
      title: "product 2",
      category: "category 1"
    },
    {
      id: "69ebb9d6-c9db-4e16-9eed-dca8b5d0dbbb",
      title: "product 3",
      category: "category 2"
    }
  ];
  
  constructor() {
  }

  ngOnInit() {
  }

}

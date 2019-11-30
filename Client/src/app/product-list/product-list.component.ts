import { Component, OnInit, Input } from '@angular/core';
import { Product } from '../product';
import { Injectable } from '@angular/core';

import { ProductService } from '../product.service'
import { EventService } from '../event.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
@Injectable()
export class ProductListComponent implements OnInit {
  products: Product[];
  @Input() take: number;

  constructor(
    private productService: ProductService,
    private eventService: EventService) {
  }

  ngOnInit() {
    this.get(0);
    this.eventService.productCreated.subscribe(() => this.get(0));
    this.eventService.pageChanged.subscribe(page => this.changePage(page));
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

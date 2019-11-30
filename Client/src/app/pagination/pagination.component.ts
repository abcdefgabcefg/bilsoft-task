import { Component, OnInit, Output, Input, EventEmitter, Injectable } from '@angular/core';

import { ProductService } from '../product.service'; 

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit{
  pages: number[];
  @Output() pageChanged : EventEmitter<number> = new EventEmitter();
  @Input() take: number;

  constructor(private productService: ProductService) {

  }

  ngOnInit(){
    this.productService.count().subscribe(productsCount => {
      const pagesCount = Math.ceil(productsCount / this.take);
      this.pages = [...Array(pagesCount).keys()].map(page => ++page);
    });
   }

  changePage(page: number): void{
    this.pageChanged.emit(page);
   }
}

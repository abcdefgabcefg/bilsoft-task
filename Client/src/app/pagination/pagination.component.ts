import { Component, OnInit, Output, Input, EventEmitter, Injectable } from '@angular/core';

import { ProductService } from '../product.service'; 
import { EventService } from '../event.service';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
@Injectable()
export class PaginationComponent implements OnInit{
  pages: number[];
  @Output() pageChanged : EventEmitter<number> = new EventEmitter();
  @Input() take: number;

  constructor(
    private productService: ProductService,
    private eventService: EventService) {

  }

  ngOnInit(){
    this.getCount();

    this.eventService.productCreated.subscribe(() => this.getCount());
   }

  changePage(page: number): void{
    this.pageChanged.emit(page);
   }

   getCount(): void{
    this.productService.count().subscribe(productsCount => {
      const pagesCount = Math.ceil(productsCount / this.take);
      this.pages = [...Array(pagesCount).keys()].map(page => ++page);
    });
   }
}

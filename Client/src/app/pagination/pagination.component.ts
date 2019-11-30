import { Component, OnInit, Input, Injectable } from '@angular/core';

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
  @Input() take: number;
  current: number = 1;

  constructor(
    private productService: ProductService,
    private eventService: EventService) {

  }

  ngOnInit(){
    this.getCount();

    this.eventService.productCreated.follow(() => this.getCount());
   }

  changePage(page: number): void{
    this.current = page;
    this.eventService.pageChanged.nofify(page);
   }

   getCount(): void{
    this.productService.count().subscribe(productsCount => {
      this.current = 1;

      const pagesCount = Math.ceil(productsCount / this.take);
      this.pages = [...Array(pagesCount).keys()].map(page => ++page);
    });
   }
}

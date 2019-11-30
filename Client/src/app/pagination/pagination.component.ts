import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit{
  @Input() count: number;
  pages: number[];
  @Output() pageChanged : EventEmitter<number> = new EventEmitter();

  ngOnInit(){
    this.pages = [...Array(this.count).keys()].map(page => ++page);
   }

  changePage(page: number): void{
    this.pageChanged.emit(page);
   }
}

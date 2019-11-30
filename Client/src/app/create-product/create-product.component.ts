import { Component, OnInit, Injectable, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

import { Category } from '../category';
import { CategoryService } from '../category.service';


@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
@Injectable()
export class CreateProductComponent implements OnInit {
  categories : Category[];
  createProductForm: FormGroup;
  @Output() productCreated = new EventEmitter();

  constructor(
    private http: HttpClient,
    private formBuilder: FormBuilder,
    private categoryService: CategoryService) {
    
   }

  ngOnInit() {
    this.categoryService.getAll().subscribe(categories => {
      this.categories = categories;
      
      let selectedCategory = '';
      if(categories.length){
        selectedCategory = categories[0].id;
      }
      
      this.createProductForm = this.formBuilder.group({
        title: '',
        category: [selectedCategory]
      });
    });

    this.createProductForm = this.formBuilder.group({
      title: '',
      category: ''
    });
  }

  create(product : any){
    this.http.post("https://localhost:44335/api/product", product).subscribe(() => this.productCreated.emit());
  }

}

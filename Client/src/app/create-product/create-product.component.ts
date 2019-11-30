import { Component, OnInit, Injectable } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

import { CategoryService } from '../category.service';
import { ProductService } from '../product.service';
import { EventService } from '../event.service';
import { Category } from '../category';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css']
})
@Injectable()
export class CreateProductComponent implements OnInit {
  categories : Category[];
  createProductForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private categoryService: CategoryService,
    private productService: ProductService,
    private eventService: EventService) {
    
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
    this.productService
      .create(product)
      .subscribe(() => this.eventService.productCreated.nofify());
  }

}

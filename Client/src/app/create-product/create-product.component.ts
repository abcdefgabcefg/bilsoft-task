import { Component, OnInit, Injectable } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

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
  get title(){
    return this.createProductForm.get('title');
  }

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
      
      this.createProductForm = this.createForm(selectedCategory);
    });

    this.createProductForm = this.createForm('');
  }

  createProduct(productForm : FormGroup){
    if(!productForm.valid){
      this.title.markAllAsTouched();
      return;
    }
    this.productService
      .create(productForm.value)
      .subscribe(() => this.eventService.productCreated.nofify());
  }

  createForm(selectedCategory: string): FormGroup{
    const createProductForm = this.formBuilder.group({
      title: new FormControl('', Validators.required),
      category: selectedCategory
    });

    return createProductForm;
  }
}

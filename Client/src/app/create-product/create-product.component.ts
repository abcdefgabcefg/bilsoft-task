import { Component, OnInit, Injectable } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

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
  http: HttpClient;

  constructor(
    private httpClient: HttpClient,
    private formBuilder: FormBuilder) {
      this.http = httpClient;

      this.http
      .get<Category[]>("https://localhost:44335/api/category")
      .subscribe(categories => this.categories = categories);

      this.createProductForm = formBuilder.group({
        title: '',
        category: ''
      });
   }

  ngOnInit() {
  }

  create(product: any){
    this.http.post("https://localhost:44335/api/product", product)
      .subscribe(() => console.log("Finished"));
  }

}
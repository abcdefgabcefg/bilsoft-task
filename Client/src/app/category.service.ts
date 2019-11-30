import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

import { Category } from './category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categoryUrl = "https://localhost:44335/api/category";

  constructor(private http: HttpClient) { 

  }

  getAll(): Observable<Category[]>{
    const categories = this.http.get<Category[]>(this.categoryUrl);

    return categories;
  }
}

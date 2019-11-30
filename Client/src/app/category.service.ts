import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

import { Category } from './category';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categoryUrl = environment.baseUrl + environment.categoryUrl;

  constructor(private http: HttpClient) { 

  }

  getAll(): Observable<Category[]>{
    const categories = this.http.get<Category[]>(this.categoryUrl);

    return categories;
  }
}

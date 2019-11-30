import { Injectable } from '@angular/core';
import { Event } from './event';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  productCreated: Event = new Event();
  pageChanged: Event = new Event();
}

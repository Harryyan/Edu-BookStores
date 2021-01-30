import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BookRoutingModule } from './routing/book-routing.module';
import { BookListComponent } from './book-list/book-list.component';

@NgModule({
  declarations: [BookListComponent],
  imports: [
    CommonModule,
    BookRoutingModule
  ]
})
export class BookModule { }

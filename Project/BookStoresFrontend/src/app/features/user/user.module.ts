import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './routing/user-routing.module';
import { SharedModule } from '../../shared/shared.module';
import { UserlistComponent } from './user-list/user-list.component';
import { TableModule } from 'primeng/table';
import { ProgressBarModule } from 'primeng/progressbar';


@NgModule({
  declarations: [
    UserlistComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    UserRoutingModule,
    TableModule,
    ProgressBarModule
  ]
})

export class UserModule { }

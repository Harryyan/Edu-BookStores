import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';

import { DropdownModule } from 'primeng/dropdown';
import { MenubarModule } from 'primeng/menubar';
import { InputTextModule } from 'primeng/inputtext';
import { CalendarModule } from 'primeng/calendar';
import { InputSwitchModule } from 'primeng/inputswitch';
import { ButtonModule } from 'primeng/button';
import { FullCalendarModule } from 'primeng/fullcalendar';
import { MessageModule } from 'primeng/message';
import { TranslateModule } from '@ngx-translate/core';

import { TopNavComponent } from '../core/components/top-nav/top-nav.component';
import { LayoutComponent } from '../core/components/layout/layout.component';
import { PageNotFoundComponent } from '../core/components/page-not-found/page-not-found.component';

@NgModule({
  declarations: [
    TopNavComponent,
    LayoutComponent,
    PageNotFoundComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    DropdownModule,
    MenubarModule,
    InputTextModule,
    CalendarModule,
    InputSwitchModule,
    ButtonModule,
    FullCalendarModule,
    MessageModule,
    TranslateModule    
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule,
    DropdownModule,
    MenubarModule,
    InputTextModule,
    CalendarModule,
    InputSwitchModule,
    ButtonModule,
    FullCalendarModule,
    MessageModule,
    TranslateModule,
    TopNavComponent,
    LayoutComponent
  ]
})
export class SharedModule { }
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { NgxPaginationModule } from 'ngx-pagination'
import { PhoneFormat } from './pipe/phoneFormat';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    PhoneFormat
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, NgxPaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

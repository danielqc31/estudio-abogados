import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";

import { LoginInfoComponent } from './login-info/login-info.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    LoginInfoComponent
  ],
  exports: [
    LoginInfoComponent
  ]
})
export class UserModule { }

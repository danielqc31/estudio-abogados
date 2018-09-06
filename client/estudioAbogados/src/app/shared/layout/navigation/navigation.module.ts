import { NgModule } from '@angular/core';
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";

import { NavigationComponent } from './navigation.component';
import { UserModule } from '../../user/user.module';
import { NavigationMenuDirective } from './navigation-menu.directive';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    UserModule
  ],
  declarations: [
    NavigationComponent,
    NavigationMenuDirective
  ],
  exports: [
    NavigationComponent
  ]
})
export class NavigationModule { }

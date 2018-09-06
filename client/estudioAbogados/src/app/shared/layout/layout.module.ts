import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { MainLayoutComponent } from './app-layouts/main-layout.component';
import { HeaderModule } from './header/header.module';
import { NavigationModule } from './navigation/navigation.module';
import { RibbonComponent } from './ribbon/ribbon.component';
import { RouteBreadcrumbsComponent } from './ribbon/route-breadcrumbs.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    HeaderModule,
    NavigationModule
  ],
  declarations: [
    MainLayoutComponent,
    RibbonComponent,
    RouteBreadcrumbsComponent
  ],
  exports: []
})
export class LayoutModule { }

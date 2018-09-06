import { NgModule } from '@angular/core';

import { HeaderComponent } from './header.component';
import { CollapseMenuComponent } from './collapse-menu/collapse-menu.component';
import { FullScreenComponent } from './full-screen/full-screen.component';

@NgModule({
  imports: [],
  declarations: [
    HeaderComponent,
    CollapseMenuComponent,
    FullScreenComponent
  ],
  exports: [
    HeaderComponent
  ]
})
export class HeaderModule { }

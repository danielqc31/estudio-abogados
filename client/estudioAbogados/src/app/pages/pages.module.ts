import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AbogadoComponent } from './abogado/abogado.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    AbogadoComponent
  ],
  exports: [
    AbogadoComponent
  ],
  providers: [],
})
export class PagesModule { }

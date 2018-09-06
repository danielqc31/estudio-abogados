import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';

import { UserService } from './shared/user/user.service';
import { LayoutService } from './shared/layout/layout.service';
import { AbogadoService } from './services/abogado.service';

import { APP_ROUTES } from './app.routing';
import { LayoutModule } from './shared/layout/layout.module';
import { PagesModule } from './pages/pages.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    LayoutModule,
    PagesModule,
    APP_ROUTES
  ],
  providers: [UserService, LayoutService, AbogadoService],
  bootstrap: [AppComponent]
})
export class AppModule { }

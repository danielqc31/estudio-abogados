import { Routes, RouterModule } from '@angular/router';

import { MainLayoutComponent } from './shared/layout/app-layouts/main-layout.component';
import { AbogadoComponent } from './pages/abogado/abogado.component';

const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      { path: '', redirectTo: 'mantenimientos/abogado', pathMatch: 'full' },
      {
        path: 'mantenimientos',
        data: { pageTitle: 'Mantenimientos' },
        children: [
          { path: '', redirectTo: 'abogado', pathMatch: 'full' },
          { path: 'abogado', component: AbogadoComponent, data: { pageTitle: 'Abogados' } }
        ]
      }
    ]
  }
];

export const APP_ROUTES = RouterModule.forRoot(routes);

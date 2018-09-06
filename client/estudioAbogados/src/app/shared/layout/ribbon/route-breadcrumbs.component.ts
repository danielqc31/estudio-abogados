import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';

import 'rxjs/add/operator/filter';

@Component({
  selector: 'app-route-breadcrumbs',
  template: `
    <ol class="breadcrumb">
      <li *ngFor="let item of items">{{item}}</li>
    </ol>
  `,
  styles: []
})
export class RouteBreadcrumbsComponent implements OnInit, OnDestroy {

  public items: Array<string> = [];
  private sub: any;

  constructor(private router: Router) { }

  ngOnInit() {
    this.extract(this.router.routerState.root);
    this.sub = this.router.events
      .filter(e => e instanceof NavigationEnd)
      .subscribe(v => {
        this.items = [];
        this.extract(this.router.routerState.root)
      });
  }

  ngOnDestroy() {
    this.sub.unsubscribe()
  }

  extract(route){
    let pageTitle = route.data.value['pageTitle'];
    if(pageTitle && this.items.indexOf(pageTitle) == -1){
      this.items.push(route.data.value['pageTitle'])
    }
    if(route.children){
      route.children.forEach(it=>{
        this.extract(it)
      })
    }
  }

}

import { Injectable } from '@angular/core';
import { Subject } from 'rxjs/Subject';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/observable/fromEvent';
import "rxjs/add/operator/map";
import "rxjs/add/operator/debounceTime";

const store = {
  mobileViewActivated: false,
  menuCollapsed: false
}

@Injectable()
export class LayoutService {

  store:any;

  private subject:Subject<any>;

  constructor() {
    this.subject = new Subject();
    this.store = store;
    this.trigger();

    Observable.fromEvent(window, 'resize').debounceTime(100).map(()=>{
      this.trigger()
    }).subscribe()
  }

  subscribe(next, err?, complete?) {
    return this.subject.subscribe(next, err, complete)
  }

  onCollapseMenu(value?){
    if(typeof value !== 'undefined'){
      this.store.menuCollapsed = value
    } else {
      this.store.menuCollapsed = !this.store.menuCollapsed;
    }

    this.trigger();
  }

  trigger() {
    this.processBody(this.store);
    this.subject.next(this.store)
  }

  processBody(state) {
    let $body = $('body');

    state.mobileViewActivated = $(window).width() < 979;
    $body.toggleClass('mobile-view-activated', state.mobileViewActivated);

    $body.toggleClass("hidden-menu", state.menuCollapsed);
  }

}

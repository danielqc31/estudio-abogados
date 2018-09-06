import { Directive, OnInit, AfterViewInit, ElementRef, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';

import { LayoutService } from '../layout.service';

@Directive({
  selector: '[appNavigationMenu]'
})
export class NavigationMenuDirective implements OnInit, AfterViewInit, OnDestroy {

  private $menu: any;
  private layoutSub: Subscription;

  constructor(private menu: ElementRef, public layoutService: LayoutService) {
    this.$menu = $(this.menu.nativeElement);
  }

  ngOnInit(): void {
    this.layoutSub = this.layoutService.subscribe((store) => {
      this.processLayout(store);
    });

    // collapse menu on mobiles
    $('[routerLink]', this.$menu).on('click', () => {
      if (this.layoutService.store.mobileViewActivated) {
        this.layoutService.onCollapseMenu();
      }
    });
  }

  ngAfterViewInit(): void {
    this.$menu.find('li:has(> ul)').each((i, li) => {
      let $menuItem = $(li);
      let $a = $menuItem.find('>a');
      let sign = $('<b class="collapse-sign"><em class="fa fa-plus-square-o"/></b>');

      $a.on('click', (e) => {
        this.toggle($menuItem);
        e.stopPropagation();
        return false;
      }).append(sign);
    });

    setTimeout(()=>{
      this.processLayout(this.layoutService.store)
    }, 200);
  }

  ngOnDestroy() {
    this.layoutSub.unsubscribe();
  }

  private processLayout = (layoutStore) => {
    this.$menu.find('li.active').each((i, li) => {
      $(li).parents('li').each((j, parentLi) => {
        this.toggle($(parentLi), true)
      })
    })
  };

  private toggle($el, condition = !$el.data('open')) {
    $el.toggleClass('open', condition);

    if (condition) {
      $el.find('>ul').slideDown();
    } else {
      $el.find('>ul').slideUp();
    }

    $el.find('>a>.collapse-sign>em')
      .toggleClass('fa-plus-square-o', !condition)
      .toggleClass('fa-minus-square-o', condition);

    $el.data('open', condition);

    if (condition) {
      $el.siblings('.open').each((i, it) => {
        let sib = $(it);
        this.toggle(sib, false)
      })
    }
  }

}

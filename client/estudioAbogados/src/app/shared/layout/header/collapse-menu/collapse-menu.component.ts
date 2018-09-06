import { Component } from '@angular/core';

import { LayoutService } from '../../layout.service';

@Component({
  selector: 'app-collapse-menu',
  templateUrl: './collapse-menu.component.html',
  styles: []
})
export class CollapseMenuComponent {

  constructor(private layoutService: LayoutService) { }

  onToggle() {
    this.layoutService.onCollapseMenu();
  }

}

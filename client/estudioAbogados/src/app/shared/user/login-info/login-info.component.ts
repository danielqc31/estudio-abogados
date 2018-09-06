import { Component, OnInit } from '@angular/core';

import { UserService } from '../user.service';

@Component({
  selector: 'app-login-info',
  templateUrl: './login-info.component.html',
  styles: []
})
export class LoginInfoComponent implements OnInit {

  user: any;

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.userService.getLoginInfo().subscribe(user => {
      this.user = user;
    });
  }

  toggleShortcut() {}

}

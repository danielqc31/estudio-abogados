import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import 'rxjs/add/observable/of';

@Injectable()
export class UserService {

  constructor() {}

  getLoginInfo(): Observable<any> {
    const user = {
      "username": "Daniel Quispe",
      "picture": "assets/img/avatars/sunny.png",
      "activity": 12
    };

    return Observable.of(user);
  }
}

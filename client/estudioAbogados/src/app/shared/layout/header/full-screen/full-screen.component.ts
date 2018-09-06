import { Component } from '@angular/core';

@Component({
  selector: 'app-full-screen',
  templateUrl: './full-screen.component.html',
  styles: []
})
export class FullScreenComponent {

  constructor() { }

  onToggle() {
    var $body = $('body');

    var documentMethods = {
      enter: ['requestFullscreen', 'mozRequestFullScreen', 'webkitRequestFullscreen', 'msRequestFullscreen'],
      exit: ['cancelFullScreen', 'mozCancelFullScreen', 'webkitCancelFullScreen', 'msCancelFullScreen']
    };

    if (!$body.hasClass("full-screen")) {
      $body.addClass("full-screen");
      document.documentElement[documentMethods.enter.filter((method) => {
        return document.documentElement[method]
      })[0]]()
    } else {
      $body.removeClass("full-screen");
      document[documentMethods.exit.filter((method)=> {
        return document[method]
      })[0]]()
    }
  }

}

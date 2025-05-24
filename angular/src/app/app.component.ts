import { Component } from '@angular/core';
import { NgxSpinnerModule } from 'ngx-spinner';
import {
  Router,
  NavigationStart,
  NavigationEnd,
  NavigationCancel,
  NavigationError,
} from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  standalone: false,
  selector: 'app-root',
  template: `
    <ngx-spinner bdColor="rgba(0,0,0,0.3)" size="medium" color="#fff" type="ball-spin-clockwise">
    </ngx-spinner>
    <router-outlet></router-outlet>
  `,
})
export class AppComponent {
  constructor(private router: Router, private spinner: NgxSpinnerService) {
    this.router.events.subscribe(event => {
      if (event instanceof NavigationStart) {
        this.spinner.show();
      }

      if (
        event instanceof NavigationEnd ||
        event instanceof NavigationCancel ||
        event instanceof NavigationError
      ) {
        this.spinner.hide();
      }
    });
  }
}

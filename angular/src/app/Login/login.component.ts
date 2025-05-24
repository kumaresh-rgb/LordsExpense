// ✅ login.component.ts
import { Component } from '@angular/core';
import { AuthService } from '@abp/ng.core';
import { Router } from '@angular/router';

@Component({
  standalone: false,
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../login.component.scss'],
})
export class LoginComponent {
  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit(): void {
    if (this.authService.isAuthenticated) {
      this.router.navigate(['/dashboard']); // ✅ Redirect if already logged in
    }
  }

  login() {
    this.authService.navigateToLogin({ returnUrl: '/dashboard' });
  }
}

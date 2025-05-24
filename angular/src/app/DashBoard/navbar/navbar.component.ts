import { Component, HostListener } from '@angular/core';

@Component({
  standalone: false,
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss',
})
export class NavbarComponent {
  isMobileMenuOpen = false;

  toggleMobileMenu() {
    this.isMobileMenuOpen = !this.isMobileMenuOpen;
  }

  @HostListener('window:resize')
  onWindowResize() {
    // Auto-close mobile menu if resizing to desktop
    if (window.innerWidth > 768) {
      this.isMobileMenuOpen = false;
    }
  }
}

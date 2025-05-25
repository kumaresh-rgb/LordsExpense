import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MultiSelectModule } from 'primeng/multiselect';
import { ButtonModule } from 'primeng/button';
import { TablegridComponent } from '../tablegrid/tablegrid.component';
import { AuthService } from '@abp/ng.core';
import { Router } from '@angular/router';

interface Country {
  name: string;
  code: string;
}

@Component({
  standalone: true,
  imports: [FormsModule, MultiSelectModule, ButtonModule, TablegridComponent],
  selector: 'app-transaction',
  templateUrl: './transaction.component.html',
  styleUrl: './transaction.component.scss',
})
export class TransactionComponent {
  countries!: Country[];

  selectedCountries!: Country[];

  constructor(private authService: AuthService, private router: Router) {
    this.countries = [
      { name: 'Australia', code: 'AU' },
      { name: 'Brazil', code: 'BR' },
      { name: 'China', code: 'CN' },
      { name: 'Egypt', code: 'EG' },
      { name: 'France', code: 'FR' },
      { name: 'Germany', code: 'DE' },
      { name: 'India', code: 'IN' },
      { name: 'Japan', code: 'JP' },
      { name: 'Spain', code: 'ES' },
      { name: 'United States', code: 'US' },
    ];
  }

  openNew() {
    if (this.authService.isAuthenticated) {
      this.router.navigate(['/createNew']);
    } else {
      this.router.navigate(['/login']);
    }
  }
}

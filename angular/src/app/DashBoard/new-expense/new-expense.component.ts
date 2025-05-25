import { Router } from '@angular/router';
import { CardModule } from '@abp/ng.theme.shared';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { ButtonModule } from 'primeng/button';
import { CalendarModule } from 'primeng/calendar';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';
import { BarchartComponent } from 'src/app/Chart/barchart/barchart.component';
import { DatePickerModule } from 'primeng/datepicker';
import { Location } from '@angular/common';

import { CreateOrUpdateInExpDto, ServiceProxy } from '../service-proxies/service-proxies';
import { firstValueFrom } from 'rxjs';

@Component({
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    CardModule,
    DropdownModule,
    InputTextModule,
    InputTextModule,
    CalendarModule,
    ButtonModule,
    DatePickerModule,
  ],

  selector: 'app-new-expense',
  templateUrl: './new-expense.component.html',
  styleUrl: './new-expense.component.scss',
})
export class NewExpenseComponent {
  constructor(
    private router: Router,
    private location: Location,
    private serviceProxy: ServiceProxy
  ) {}
  expense = {
    title: '',
    amount: null,
    category: null,
    paymentmode: null,
    status: null,
    date: null,
    notes: '',
  };

  categories = [
    { label: 'Food', value: 'Food' },
    { label: 'Transport', value: 'Transport' },
    { label: 'Utilities', value: 'Utilities' },
    { label: 'Entertainment', value: 'Entertainment' },
    { label: 'Other', value: 'Other' },
  ];
  paymentmode = [
    { label: 'G Pay', value: 'gpay' },
    { label: 'ATM', value: 'atm' },
    { label: 'Phone Pay', value: 'phonepay' },
    { label: 'Bank Cheque', value: 'cheque' },
    { label: 'Other', value: 'Other' },
  ];
  status = [
    { label: 'Recieved', value: 'recieved' },
    { label: 'Not Recieved', value: 'notrecieved' },
    { label: 'In Progress', value: 'progress' },
    { label: 'Completed', value: 'Completed' },
    { label: 'Other', value: 'Other' },
  ];

  submitExpense() {
    console.log('Expense Submitted:', this.expense);
    // You can emit this to a parent component or save it to a service
  }
  cancel() {
    this.location.back();
  }
  async save(form) {
    if (form.valid) {
      let request = new CreateOrUpdateInExpDto();
      request.amount = 234;
      request.categoryId = '1';
      request.categoryName = 'Entertaiment';
      request.id = '00000000-0000-0000-0000-000000000000';
      request.title = 'Petrol Expense';
      let result = await firstValueFrom(this.serviceProxy.createOrUpdateTransaction(request));
      if (result) {
        console.log('Result', result);
      }
    }
  }
}

import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CalendarModule } from 'primeng/calendar';
import { DatePickerModule } from 'primeng/datepicker';
import { BarchartComponent } from '../../Chart/barchart/barchart.component';
@Component({
  standalone: true,
  selector: 'app-summary',
  imports: [FormsModule, CalendarModule, DatePickerModule, BarchartComponent], // ✅ Important!
  templateUrl: './summary.component.html',
  styleUrl: './summary.component.scss',
})
export class SummaryComponent {
  date: Date | undefined;
}

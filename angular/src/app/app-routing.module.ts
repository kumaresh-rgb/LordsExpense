// ✅ app-routing.module.ts
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './DashBoard/dashboard.component';
import { LoginComponent } from './Login/login.component';
import { authGuard } from '@abp/ng.core';
import { SummaryComponent } from './DashBoard/summary/summary.component';
import { TransactionComponent } from './DashBoard/transactionGrid/transaction.component';
import { CashflowComponent } from './DashBoard/cashflow/cashflow.component';
import { ReportComponent } from './DashBoard/report/report.component';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent, canActivate: [authGuard] },
  { path: 'summary', component: SummaryComponent, canActivate: [authGuard] },
  { path: 'cashflow', component: CashflowComponent, canActivate: [authGuard] },
  { path: 'report', component: ReportComponent, canActivate: [authGuard] },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

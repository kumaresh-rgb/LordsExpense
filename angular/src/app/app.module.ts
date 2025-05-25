import { CoreModule, provideAbpCore, withOptions } from '@abp/ng.core';
import { provideAbpOAuth } from '@abp/ng.oauth';
import { provideSettingManagementConfig } from '@abp/ng.setting-management/config';
import { provideFeatureManagementConfig } from '@abp/ng.feature-management';
import { ThemeSharedModule, provideAbpThemeShared } from '@abp/ng.theme.shared';
import { provideIdentityConfig } from '@abp/ng.identity/config';
import { provideAccountConfig } from '@abp/ng.account/config';
import { provideTenantManagementConfig } from '@abp/ng.tenant-management/config';
import { registerLocale } from '@abp/ng.core/locale';
import { ThemeLeptonXModule } from '@abp/ng.theme.lepton-x';
import { SideMenuLayoutModule } from '@abp/ng.theme.lepton-x/layouts';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './DashBoard/dashboard.component';
import { LoginComponent } from './Login/login.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { SummaryComponent } from './DashBoard/summary/summary.component';
import { CashflowComponent } from './DashBoard/cashflow/cashflow.component';
import { TransactionComponent } from './DashBoard/transactionGrid/transaction.component';
import { NavbarComponent } from './DashBoard/navbar/navbar.component';
import { ReportComponent } from './DashBoard/report/report.component';

@NgModule({
  declarations: [AppComponent, DashboardComponent, NavbarComponent, LoginComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    CoreModule,
    NgxSpinnerModule,
    SummaryComponent,
    TransactionComponent,
  ],
  providers: [
    provideAbpCore(
      withOptions({
        environment,
        registerLocaleFn: registerLocale(),
      })
    ),
    provideAbpOAuth(),
    provideIdentityConfig(),
    provideSettingManagementConfig(),
    provideFeatureManagementConfig(),
    provideAccountConfig(),
    provideTenantManagementConfig(),
    provideAbpThemeShared(),
  ],

  bootstrap: [AppComponent],
})
export class AppModule {}

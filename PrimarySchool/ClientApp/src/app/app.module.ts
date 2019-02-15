import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { appRoutes } from './app.routing';
import { AdministratorsComponent } from './administrators/administrators.component';
import { MatSidenav, MatSidenavContent, MatSidenavContainer, MatRadioButton, MatRadioGroup, MatIcon, MatToolbarRow, MatToolbar, MatTab, MatTabGroup, MatRippleModule, MatTabHeader } from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AdministratorsComponent,
    MatSidenav,
    MatSidenavContent,
    MatSidenavContainer,
    MatRadioButton,
    MatRadioGroup,
    MatIcon,
    MatToolbarRow,
    MatToolbar,
    MatTab,
    MatTabGroup,
    MatTabHeader
  ],
  imports: [
    MatRippleModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

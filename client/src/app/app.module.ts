import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { JobComponent } from './job/job.component';
import { RegisterComponent } from './register/register.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { ColMemberDetailComponent } from './colmembers/colmember-detail/colmember-detail.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { HomeComponent } from './home/home.component';
import { TalentComponent } from './talent/talent.component';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { MemberCardComponent } from './members/member-card/member-card.component';
import { JwtInterceptor } from './_interceptors/jwt.interceptor';
import { UserLoginComponent } from './user-login/user-login.component';
import { ColUserLoginComponent } from './coluser-login/coluser-login.component';
import { ColRegisterComponent } from './colregister/colregister.component';
import { HsStudentComponent } from './hsstudent/hsstudent.component';
import { CollegeComponent } from './college/college.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { EmpRegisterComponent } from './empregister/empregister.component';
import { HsRegisterComponent } from './hsregister/hsregister.component';
import { ColMemberListComponent } from './colmembers/colmember-list/colmember-list.component';
import { ColListsComponent } from './collists/collists.component';
import { ColMessagesComponent } from './colmessages/colmessages.component';
import { DonorCardComponent } from './donors/donor-card/donor-card.component';
import { DonorDetailComponent } from './donors/donor-detail/donor-detail.component';
import { DonorListComponent } from './donors/donor-list/donor-list.component';
import { ColmemberCardComponent } from './colmembers/colmember-card/colmember-card.component';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { CompanyEditComponent } from './members/company-edit/company-edit.component';
import { CollegeEditComponent } from './colmembers/college-edit/college-edit.component';
import { HsEditComponent } from './colmembers/hs-edit/hs-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    JobComponent,
    RegisterComponent,
    MemberListComponent,
    MemberDetailComponent,
    ColMemberDetailComponent,
    ListsComponent,
    MessagesComponent,
    HomeComponent,
    TalentComponent,
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent,
    MemberCardComponent,
    UserLoginComponent,
    ColUserLoginComponent,
    ColRegisterComponent,
    HsStudentComponent,
    CollegeComponent,
    EmpRegisterComponent,
    HsRegisterComponent,
    ColMemberListComponent,
    ColListsComponent,
    ColMessagesComponent,
    DonorCardComponent,
    DonorDetailComponent,
    DonorListComponent,
    ColmemberCardComponent,
    MemberEditComponent,
    CompanyEditComponent,
    CollegeEditComponent,
    HsEditComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule,
    BsDropdownModule.forRoot()
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true},
    {provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

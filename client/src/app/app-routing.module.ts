import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { JobComponent } from './job/job.component';
import { TalentComponent } from './talent/talent.component';
import { ListsComponent } from './lists/lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { UserLoginComponent } from './user-login/user-login.component';
import { ColUserLoginComponent } from './coluser-login/coluser-login.component';
import { RegisterComponent } from './register/register.component';
import { ColRegisterComponent } from './colregister/colregister.component';
import { CollegeComponent } from './college/college.component';
import { HsStudentComponent } from './hsstudent/hsstudent.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'job', component: JobComponent },
  { path: 'talent', component: TalentComponent },
  { path: 'college', component: CollegeComponent },
  { path: 'hsstudent', component: HsStudentComponent },
  // {
  //   path: 'memberlist',
  //   component: MemberListComponent,
  //   canActivate: [AuthGuard],
  // },
  { path: 'members/:username', component: MemberDetailComponent },
  { path: 'memberlist', component: MemberListComponent },
  { path: 'userlogin', component: UserLoginComponent },
  { path: 'coluserlogin', component: ColUserLoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'colregister', component: ColRegisterComponent },
  { path: 'lists', component: ListsComponent },
  { path: 'messages', component: MessagesComponent },
  { path: 'errors', component: TestErrorsComponent },
  { path: 'not-found', component: NotFoundComponent },
  { path: 'server-error', component: ServerErrorComponent },
  { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

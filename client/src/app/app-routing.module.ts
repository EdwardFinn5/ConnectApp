import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { JobsComponent } from './jobs/jobs.component';
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
import { ColuserLoginComponent } from './coluser-login/coluser-login.component';
import { RegisterComponent } from './register/register.component';
import { ColregisterComponent } from './colregister/colregister.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'jobs', component: JobsComponent },
  { path: 'talent', component: TalentComponent },
  // {
  //   path: 'memberlist',
  //   component: MemberListComponent,
  //   canActivate: [AuthGuard],
  // },
  { path: 'members/:username', component: MemberDetailComponent },
  { path: 'memberlist', component: MemberListComponent },
  { path: 'userlogin', component: UserLoginComponent },
  { path: 'coluserlogin', component: ColuserLoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'colregister', component: ColregisterComponent },
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

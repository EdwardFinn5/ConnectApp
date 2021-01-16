import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { JobComponent } from './job/job.component';
import { TalentComponent } from './talent/talent.component';
import { ListsComponent } from './lists/lists.component';
import { ColListsComponent } from './collists/collists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { ColMemberDetailComponent } from './colmembers/colmember-detail/colmember-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { ColMemberListComponent } from './colmembers/colmember-list/colmember-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ColMessagesComponent } from './colmessages/colmessages.component';
import { AuthGuard } from './_guards/auth.guard';
import { ColAuthGuard } from './_guards/col-auth.guard';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { UserLoginComponent } from './user-login/user-login.component';
import { ColUserLoginComponent } from './coluser-login/coluser-login.component';
import { RegisterComponent } from './register/register.component';
import { HsRegisterComponent } from './hsregister/hsregister.component';
import { EmpRegisterComponent } from './empregister/empregister.component';
import { ColRegisterComponent } from './colregister/colregister.component';
import { CollegeComponent } from './college/college.component';
import { HsStudentComponent } from './hsstudent/hsstudent.component';
import { DonorCardComponent } from './donors/donor-card/donor-card.component';
import { DonorDetailComponent } from './donors/donor-detail/donor-detail.component';
import { DonorListComponent } from './donors/donor-list/donor-list.component';



const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'job', component: JobComponent },
  { path: 'talent', component: TalentComponent },
  { path: 'college', component: CollegeComponent },
  { path: 'hsstudent', component: HsStudentComponent },
  { path: 'donorcard', component: DonorCardComponent },
  { path: 'donordetail', component: DonorDetailComponent },
  { path: 'donorlist', component: DonorListComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'memberlist', component: MemberListComponent },
      { path: 'members/:username', component: MemberDetailComponent},
      { path: 'lists', component: ListsComponent },
      { path: 'messages', component: MessagesComponent },
    ]
  },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [ColAuthGuard],
    children: [
      { path: 'colmemberlist', component: MemberListComponent }, 
      { path: 'colmemberdetail/:id', component: ColMemberDetailComponent },
      { path: 'collists', component: ColListsComponent },
      { path: 'colmessages', component: ColMessagesComponent },
    ]
  },
  { path: 'userlogin', component: UserLoginComponent },
  { path: 'coluserlogin', component: ColUserLoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'hsregister', component: HsRegisterComponent },
  { path: 'empregister', component: EmpRegisterComponent },
  { path: 'colregister', component: ColRegisterComponent },
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

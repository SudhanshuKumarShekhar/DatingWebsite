import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MemberListsComponent } from './members/member-lists/member-lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MessagesComponent } from './messages/messages.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'lists', component:ListsComponent},
  {path:'members', component:MemberListsComponent},
  {path:'members/:id', component:MemberDetailComponent},
  {path:'messages', component:MessagesComponent},
  {path:'**', component:HomeComponent, pathMatch:'full'},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

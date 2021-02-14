import { Injectable } from '@angular/core';
import { CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { CompanyEditComponent } from '../members/company-edit/company-edit.component';

@Injectable({
  providedIn: 'root'
})
export class PreventUnsavedCompanyChangesGuard implements CanDeactivate<unknown> {
  canDeactivate(component: CompanyEditComponent) : boolean {
    if (component.editForm.dirty) {
      return confirm('Are you sure you want to continue? Any unsaved changes will be lost')
    }
    return true;
  }
  
}
import { User } from './user';

export class UserParams {
  appUserType: string;
  major = 'Accounting';
  position = 'Finance';
  pageNumber = 1;
  pageSize = 50;
  orderBy = 'lastActive';

  constructor(user: User) {
    this.appUserType =
      user.appUserType === 'ColStudent' ? 'EmpHr' : 'ColStudent';
  }
}

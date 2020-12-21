import { CollegePrep } from './collegePrep';
import { EmpOpp } from './empOpp';
import { Photo } from './photo';

export interface Member {
  id: number;
  username: string;
  photoUrl?: string;
  logoUrl?: string;
  classYear?: string;
  major?: string;
  hometown?: string;
  academicPlus?: string;
  workPlus?: string;
  company?: string;
  position?: string;
  fullName: string;
  nickName: string;
  email: string;
  created: Date;
  lastActive: Date;
  appUserType: string;
  active: boolean;
  collegePreps: CollegePrep[];
  empOpps: EmpOpp[];
  photos: Photo[];
}

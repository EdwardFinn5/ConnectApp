import { DecimalPipe, NumberFormatStyle } from "@angular/common";
import { College } from "./college";
import { ColPhoto } from "./colPhoto";
import { HsPrep } from "./HsPrep";

export interface ColMember {
    colUserId: number;
    colUserName: string;
    firstName: string;
    lastName: string;
    colUrl?: string;
    hsStudentUrl?: string;
    adminUrl?: string;
    hsName?: string;
    hsLocation?: string;
    classYear?: string;
    proposedMajor?: string;
    extraCurricular?: string;
    dreamJob?: string;
    gpa?: string;
    tuition?: number;
    roomAndBoard?: number;
    averageAid?: number;
    netPay?: number;
    hsGradDate?: Date;
    collegeName?: string;
    collegeLocation?: string;
    collegeDescription?: string;
    collegeStreet?: string;
    collegeCity?: string;
    collegeState?: string;
    collegeZip?: string;
    collegeEmail?: string;
    collegeVirtual?: string;
    collegeWebsite?: string;
    collegeEnrollment?: string;
    adminContact?: string;
    adminTitle?: string;
    created: Date;
    lastActive: Date;
    colUserType: string;
    active: boolean;
    colPhotos: ColPhoto[];
    colleges: College[];
    hsPreps: HsPrep[];
  }
  

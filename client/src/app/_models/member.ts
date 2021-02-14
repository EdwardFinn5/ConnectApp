import { CollegePrep } from "./collegePrep";
import { EmpOpp } from "./empOpp";
import { Photo } from "./photo";


export interface Member {
    id: number;
    username: string;
    photoUrl?: string;
    logoUrl?: string;
    studentUrl?: string;
    hrUrl?: string;
    classYear?: string;
    college?: string;
    firstName?: string;
    lastName?: string;
    major?: string;
    gpa?: string;
    hometown?: string;
    academicPlus?: string;
    gradDate?: Date;
    workPlus?: string;
    dreamJob?: string;
    extraCurricular?: string;
    athletics?: string;
    arts?: string;
    bestEmail?: string;
    bestPhone?: string;
    company?: string;
    position?: string;
    positionLocation?: string;
    positionType?: string;
    companyDescription: string;
    positionDescription: string;
    startDate?: string;
    contact?: string;
    contactTitle?: string;
    applyEmail?: string;
    howToApply?: string;
    lookingFor?: string;
    created: Date;
    lastActive: Date;
    appUserType: string;
    active: boolean;
    collegePreps: CollegePrep[];
    empOpps: EmpOpp[];
    photos: Photo[];
}

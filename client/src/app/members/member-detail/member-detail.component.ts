import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';
import { Member } from 'src/app/_models/member';
import { MembersService } from 'src/app/_services/members.service';

@Component({
  selector: 'app-member-detail',
  templateUrl: './member-detail.component.html',
  styleUrls: ['./member-detail.component.css'],
})
export class MemberDetailComponent implements OnInit {
  member: Member;
  studentGalleryOptions: NgxGalleryOptions[];
  studentGalleryImages: NgxGalleryImage[];
  companyGalleryOptions: NgxGalleryOptions[];
  companyGalleryImages: NgxGalleryImage[];

  constructor(
    private memberService: MembersService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadMember();

    this.studentGalleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false
      }
    ]

    this.companyGalleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false
      }
    ]    
  }

  getStudentImages(): NgxGalleryImage[] {
    const colStudImageUrls = [];
    for (const photo of this.member.photos) {
      colStudImageUrls.push({
        small: photo?.studentUrl,
        medium: photo?.studentUrl,
        big: photo?.studentUrl
      })
    }
    return colStudImageUrls;
  }

  getCompanyImages(): NgxGalleryImage[] {
    const logoUrls = [];
    for (const photo of this.member.photos) {
      logoUrls.push({
        small: photo?.logoUrl,
        medium: photo?.logoUrl,
        big: photo?.logoUrl
      })
    }
    return logoUrls;
  }


  loadMember() {
    this.memberService.getMember(this.route.snapshot.paramMap.get('username')).subscribe(member => {
      this.member = member;
      this.studentGalleryImages = this.getStudentImages();
      this.companyGalleryImages = this.getCompanyImages();
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgxGalleryAnimation, NgxGalleryImage, NgxGalleryOptions } from '@kolkov/ngx-gallery';
import { ColMember } from 'src/app/_models/colMember';
import { ColMembersService } from 'src/app/_services/colmembers.service';

@Component({
  selector: 'app-colmember-detail',
  templateUrl: './colmember-detail.component.html',
  styleUrls: ['./colmember-detail.component.css']
})
export class ColMemberDetailComponent implements OnInit {
  colMember: ColMember;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(private colMemberService: ColMembersService,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadColMember();

    this.galleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false
      }
    ]

    this.galleryImages = this.getCollegeImages();
    this.galleryImages = this.getHsStudentImages();

  }

  getCollegeImages(): NgxGalleryImage[] {
    const colImageUrls = [];
    for (const colPhoto of this.colMember.colPhotos) {
      colImageUrls.push({
        small: colPhoto?.colUrl,
        medium: colPhoto?.colUrl,
        big: colPhoto?.colUrl
      })
    }
    return colImageUrls;
  }

  getHsStudentImages(): NgxGalleryImage[] {
    const hsImageUrls = [];
    for (const colPhoto of this.colMember.colPhotos) {
      hsImageUrls.push({
        small: colPhoto?.hsStudentUrl,
        medium: colPhoto?.hsStudentUrl,
        big: colPhoto?.hsStudentUrl
      })
    }
    return hsImageUrls;
  }


 loadColMember() {
    this.colMemberService.getColMember(this.route.snapshot.paramMap.get('colusername')).subscribe(colMember => {
      this.colMember = colMember;
    });
  }
}

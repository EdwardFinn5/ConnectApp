import { isPlatformBrowser } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/_models/member';
import { Photo } from 'src/app/_models/photo';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-photo-editor',
  templateUrl: './photo-editor.component.html',
  styleUrls: ['./photo-editor.component.css'],
})
export class PhotoEditorComponent implements OnInit {
  @Input() member: Member;
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl = environment.apiUrl;
  user: User;

  constructor(
    private accountService: AccountService,
    private memberService: MembersService
  ) {
    this.accountService.currentUser$
      .pipe(take(1))
      .subscribe((user) => (this.user = user));
  }

  ngOnInit(): void {
    this.initializeUploader();
  }

  fileOverBase(event: any) {
    this.hasBaseDropZoneOver = event;
  }

  setMainPhoto(photo: Photo) {
    this.memberService.setMainPhoto(photo.id).subscribe(() => {
      this.user.studentUrl = photo.studentUrl;
      this.accountService.setCurrentUser(this.user);
      this.member.studentUrl = photo.studentUrl;
      this.member.photos.forEach((p) => {
        if (p.isMain) {
          p.isMain = false;
        }
        if (p.id === photo.id) {
          p.isMain = true;
        }
      });
    });
  }

  setMainCompanyPhoto(photo: Photo) {
    this.memberService.setMainPhoto(photo.id).subscribe(() => {
      this.user.logoUrl = photo.logoUrl;
      this.accountService.setCurrentUser(this.user);
      this.member.logoUrl = photo.logoUrl;
      this.member.photos.forEach((p) => {
        if (p.isMainLogo) {
          p.isMainLogo = false;
        }
        if (p.id === photo.id) {
          p.isMainLogo = true;
        }
      });
    });
  }

  setMainHrPhoto(photo: Photo) {
    this.memberService.setMainPhoto(photo.id).subscribe(() => {
      this.user.hrUrl = photo.hrUrl;
      this.accountService.setCurrentUser(this.user);
      this.member.hrUrl = photo.hrUrl;
      this.member.photos.forEach((p) => {
        if (p.isMainHr) {
          p.isMainHr = false;
        }
        if (p.id === photo.id) {
          p.isMainHr = true;
        }
      });
    });
  }

  deletePhoto(photoId: number) {
    this.memberService.deletePhoto(photoId).subscribe(() => {
      this.member.photos = this.member.photos.filter((x) => x.id !== photoId);
    });
  }

  initializeUploader() {
    this.uploader = new FileUploader({
      url: this.baseUrl + 'users/add-photo',
      authToken: 'Bearer ' + this.user.token,
      isHTML5: true,
      allowedFileType: ['image'],
      removeAfterUpload: true,
      autoUpload: false,
      maxFileSize: 10 * 1024 * 1024,
    });

    this.uploader.onAfterAddingFile = (file) => {
      file.withCredentials = false;
    };

    this.uploader.onSuccessItem = (item, response, status, headers) => {
      if (response) {
        const photo: Photo = JSON.parse(response);
        this.member.photos.push(photo);
        if (photo.isMain) {
          this.user.studentUrl = photo.studentUrl;
          this.member.studentUrl = photo.studentUrl;
          this.accountService.setCurrentUser(this.user);
        }
        // if (photo.isMainLogo) {
        //   this.user.logoUrl = photo.logoUrl;
        //   this.member.logoUrl = photo.logoUrl;
        //   this.accountService.setCurrentUser(this.user);
        // }
      }
    };
  }
}

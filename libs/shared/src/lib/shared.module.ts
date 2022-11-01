import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UnderConstructionComponent } from './components/under-construction/under-construction.component';

@NgModule({
  declarations: [UnderConstructionComponent],
  imports: [CommonModule],
  exports: [UnderConstructionComponent]
})
export class SharedModule {}

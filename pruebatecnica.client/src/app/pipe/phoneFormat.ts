import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phoneFormat'
})
export class PhoneFormat implements PipeTransform {
  transform(value: any, args?: any): any {
    if (!value || isNaN(value)) return value
    if (typeof (value) !== 'string') value = value.toString()
    return value.replace(/(\d{3})(\d{4})(\d{4})/, "+$1 $2 $3");
  }
}

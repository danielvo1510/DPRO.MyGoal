import { MygoalTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: MygoalTemplatePage;

  beforeEach(() => {
    page = new MygoalTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

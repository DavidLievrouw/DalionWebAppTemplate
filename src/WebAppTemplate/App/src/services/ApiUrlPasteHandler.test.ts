import 'isomorphic-fetch';
import ApiUrlPasteHandler, { IApiUrlPasteHandler } from './ApiUrlPasteHandler';
import { IUrlService } from './UrlService';

let apiUrlPasteHandler: IApiUrlPasteHandler;
let urlService: IUrlService;

describe('ApiUrlPasteHandler', () => {
  describe('sanitizePastedUrl', () => {
    beforeEach(() => {
      const UrlServiceMock = jest.fn<IUrlService, any[]>(() => ({
        getAbsoluteUrl: jest.fn().mockImplementation((relativeUrl: string): string => {
          return 'https://dalion.eu/webapptemplate/' + relativeUrl;
        }),
        getApplicationUrl: jest.fn().mockImplementation((): string => {
          return 'https://dalion.eu/webapptemplate/';
        })
      }));
      urlService = new UrlServiceMock();
      apiUrlPasteHandler = new ApiUrlPasteHandler(urlService);
    });

    test("should return null when pasted content is null", () => {
      return expect(apiUrlPasteHandler.sanitizePastedUrl(null))
        .toBe(null);
    });

    test("should return empty when pasted content is empty", () => {
      return expect(apiUrlPasteHandler.sanitizePastedUrl(''))
        .toBe('');
    });

    test("should return undefined when pasted content is undefined", () => {
      return expect(apiUrlPasteHandler.sanitizePastedUrl(undefined))
        .toBe(undefined);
    });

    test("should strip single quotes from pasted text", () => {
      const input = '\'https://google.com/test/quote\'/param\'';
      const expected = 'https://google.com/test/quote/param';
      return expect(apiUrlPasteHandler.sanitizePastedUrl(input))
        .toBe(expected);
    });

    test("should strip double quotes from pasted text", () => {
      const input = '"https://google.com/test/quote"/param"';
      const expected = 'https://google.com/test/quote/param';
      return expect(apiUrlPasteHandler.sanitizePastedUrl(input))
        .toBe(expected);
    });

    test("should strip application url from pasted text", () => {
      const input = 'https://dalion.eu/webapptemplate/quote/param';
      const expected = '/quote/param';
      return expect(apiUrlPasteHandler.sanitizePastedUrl(input))
        .toBe(expected);
    });

    test("should strip application url from pasted text, even if nothing is left", () => {
      const input = 'https://dalion.eu/webapptemplate';
      const expected = '';
      return expect(apiUrlPasteHandler.sanitizePastedUrl(input))
        .toBe(expected);
    });

    test("should not strip anythig from pasted text when the application url is not there", () => {
      const input = 'https://not-dalion.eu/webapptemplate/quote/param';
      const expected = 'https://not-dalion.eu/webapptemplate/quote/param';
      return expect(apiUrlPasteHandler.sanitizePastedUrl(input))
        .toBe(expected);
    });
  });
});